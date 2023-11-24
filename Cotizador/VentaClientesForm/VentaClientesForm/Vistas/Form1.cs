using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace VentaClientesForm
{
    public partial class MainFormVentas : Form
    {
        private List<Producto> productos = BaseDeDatosHelpers.ProductosDePrueba();
        private double montoTotal = 0;
        private const double MargenPorcentajeAdi = 0.20; //Corresponde al 12%
        private const double MargenPorcentajeIVA = 0.19; //Corresponde al 19%
        private readonly int i;
        private decimal cpp = 0;
        private int cantidad;

        public MainFormVentas()
        {
            InitializeComponent();
            //Suscribe el evento Load del formulario.
            txtCodigoBarras.Focus();
            this.Load += MainFormVentas_Load;
            txtMargenPorcentajeaAdi.KeyPress += new KeyPressEventHandler(txtMargenPorcentajeAdi_KeyPress);
            txtMargenPorcentajeIVA.KeyPress += new KeyPressEventHandler(txtMargenPorcentajeIVA_KeyPress);

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            txtCodigoBarras.Focus();
        }
 
        private void MainFormVentas_Load(object sender, EventArgs e)
        {
            //Al iniciarse la aplicacion, el foco estara en el codigo de barras.
            txtCodigoBarras.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string codigo = txtCodigoBarras.Text;
                //Al leerse el codigo, el foco se ira hacia el campo de cantidad.
                txtCantidad.Focus();
                e.Handled = true;
            }
        }
        
        private void txtMargenPorcentajeAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números positivos enteros.
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //No permitir caracteres de otro tipo.
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo numeros enteros positivos en el campo de porcentaje.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtMargenPorcentajeIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Permitir solo números positivos enteros.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //No permitir caracteres de otro tipo.
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo numeros enteros positivos en el campo de porcentaje.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoBarras.Text;
            Producto producto = BaseDeDatos.ProductosDePrueba().Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
                {
                    decimal cpp = producto.CPP;
                    decimal costoTotal = cpp * cantidad;

                    // Calcula valores adicionales y de IVA
                    decimal margenPorcentajeAdi, margenPorcentajeIVA;

                    if (Decimal.TryParse(txtMargenPorcentajeaAdi.Text.Replace("%", ""), out margenPorcentajeAdi) &&
                        Decimal.TryParse(txtMargenPorcentajeIVA.Text.Replace("%", ""), out margenPorcentajeIVA))
                    {
                        margenPorcentajeAdi /= 100;
                        margenPorcentajeIVA /= 100;

                        decimal adicional = costoTotal * margenPorcentajeAdi;
                        decimal iva = (costoTotal + adicional) * margenPorcentajeIVA;

                        decimal precioTotal = costoTotal + adicional + iva;
                        RecalcularValores();

                        bool productoExistente = false;

                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            if (row.Cells["ProductoGrilla"].Value != null && row.Cells["ProductoGrilla"].Value.ToString() == producto.Descripcion)
                            {
                                int cantidadExistente = Convert.ToInt32(row.Cells["CantidadGrilla"].Value);
                                cantidad += cantidadExistente;
                                row.Cells["CantidadGrilla"].Value = cantidad;

                                // Recalcula el costo total y lo muestra formateado como moneda
                                decimal costoTotalExistente = cpp * cantidad;
                                decimal valorAdicionalExistente = (costoTotalExistente * margenPorcentajeAdi);
                                decimal valorIVAExistente = (costoTotalExistente + valorAdicionalExistente) * margenPorcentajeIVA;
                                decimal precioTotalExistente = costoTotalExistente + valorAdicionalExistente + valorIVAExistente;

                                row.Cells["PrecioTotalGrilla"].Value = precioTotalExistente.ToString("C"); // Formatea el precio como moneda

                                productoExistente = true;
                                break;
                            }
                        }

                        if (!productoExistente)
                        {
                            // Agrega nueva fila a la grilla dgvVentas y formatea el precio como moneda
                            dgvVentas.Rows.Add(producto.Descripcion, cantidad, precioTotal.ToString("C"));
                        }

                        // Calcula y actualiza el valor final
                        decimal montoTotal = 0M; // Inicializa valorFinal como decimal

                        foreach (DataGridViewRow row in dgvVentas.Rows)
                        {
                            // Verifica si el valor de la celda no es nulo y es convertible a decimal
                            object cellValue = row.Cells["PrecioTotalGrilla"].Value;
                            if (cellValue != null &&
                                decimal.TryParse(cellValue.ToString(),
                                System.Globalization.NumberStyles.Currency,
                                System.Globalization.CultureInfo.CurrentCulture, out decimal precioTotalGrilla))
                            {
                                montoTotal += precioTotalGrilla; // Suma costoTotal a valorFinal
                            }
                        }

                        // Formatea y muestra el valor final como moneda en el campo de texto
                        txtMontoTotal.Text = montoTotal.ToString("C");
                        CalcularMontoTotal();
                    }
                    else
                    {
                        // Mostrar un mensaje de error si la conversión de porcentajes falla
                    }
                }
                else
                {
                    MessageBox.Show("Cantidad inválida. Por favor, ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Después de agregar el producto, limpiar campos y establecer el foco en el código de barras.
            LimpiarCampos();
            txtCodigoBarras.Focus();
        }

        private void MostrarMontoTotal()
        {
            double montoTotal = 0;
            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                double valorFila = Convert.ToDouble(row.Cells["PrecioTotalGrilla"].Value);
                montoTotal += valorFila;
            }
            txtMontoTotal.Text = montoTotal.ToString();
            txtCodigoBarras.Focus();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvVentas.SelectedRows[0];

                // Verificar si la celda del ProductoGrilla está vacía o nula
                if (selectedRow.Cells["ProductoGrilla"].Value == null || string.IsNullOrWhiteSpace(selectedRow.Cells["ProductoGrilla"].Value.ToString()))
                {
                    MessageBox.Show("La fila seleccionada está vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verifica si el valor de la celda no es nulo y es convertible a decimal
                object cellValue = selectedRow.Cells["PrecioTotalGrilla"].Value;
                if (cellValue != null &&
                    decimal.TryParse(cellValue.ToString(),
                    System.Globalization.NumberStyles.Currency,
                    System.Globalization.CultureInfo.CurrentCulture, out decimal valorFila))
                {
                    // Resta el valor de la fila eliminada del valor final.
                    montoTotal = (double)valorFila;
                    txtMontoTotal.Text = montoTotal.ToString("C"); // Formatea el valor final como moneda
                }

                // Elimina la fila seleccionada de la grilla.
                dgvVentas.Rows.Remove(selectedRow);

                MostrarMontoTotal();
                txtCodigoBarras.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para quitar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtCPP.Text = "0";
            txtCantidad.Text = "0";
            txtCostoTotal.Text = "0";
            txtMargenPorcentajeIVA.Text = "0";
            txtMargenPorcentajeaAdi.Text = "0";
            txtMargenValorAdicional.Text = "0";
            txtMargenValorIVA.Text = "0";
            txtPrecioTotal.Text = "0";
            txtCodigoBarras.Focus();
            txtCodigoBarras.Text = "";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //Llama al metodo de agregar producto cuando se presione enter.
                btnAgregar.PerformClick();
                e.Handled = true;
            }
            else if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //Permite solo digitos y teclas de control.
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvVentas.Rows.Clear();
            montoTotal = 0;
            txtMontoTotal.Text = "0";
            txtCodigoBarras.Text = "";
            txtCodigoBarras.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoBarras_TextChanged(object sender, EventArgs e)
        {
            txtCodigoBarras.Focus();
            //Desactivar el boton "Agregar" mientras se escanea el codigo de barras.
            //btnAgregar.Enabled = false;

            string codigo = txtCodigoBarras.Text;
            Producto producto = BaseDeDatos.ProductosDePrueba().Find(p => p.Codigo == codigo);

            if (producto != null)
            {
                // Mostrar la descripción y el costo unitario del producto
                txtDescripcion.Text = producto.Descripcion;
                txtCPP.Text = producto.CPP.ToString("C"); // Mostrar como moneda

                // Configurar valores predeterminados y calcular el costo total
                int cantidad = 1; // Cantidad predeterminada
                double cpp = (double)producto.CPP;
                double costoTotal = cpp * cantidad;

                // Calcular valores de adicional, iva y total
                double margenPorcentajeAdi = 0.20; // Porcentaje adicional predeterminado (12%)
                double margenPorcentajeIVA = 0.19; // Porcentaje de IVA predeterminado (19%)

                double margenValorAdicional = costoTotal * margenPorcentajeAdi;
                double margenValorIVA = (costoTotal + margenValorAdicional) * margenPorcentajeIVA;

                double PrecioTotal = costoTotal + margenValorAdicional + margenValorIVA;
                RecalcularValores();

                // Mostrar valores en los campos correspondientes
                txtCantidad.Text = cantidad.ToString();
                txtCostoTotal.Text = costoTotal.ToString("C"); // Mostrar como moneda
                txtMargenPorcentajeaAdi.Text = (margenPorcentajeAdi * 100).ToString() + "%";
                txtMargenValorAdicional.Text = margenValorAdicional.ToString("C"); // Mostrar como moneda
                txtMargenPorcentajeIVA.Text = (margenPorcentajeIVA * 100).ToString() + "%";
                txtMargenValorIVA.Text = margenValorIVA.ToString("C"); // Mostrar como moneda
                txtPrecioTotal.Text = PrecioTotal.ToString("C"); // Mostrar como moneda

                txtCantidad.Focus();
            }
            else
            {
                // Limpiar campos si el producto no se encuentra
                LimpiarCampos();
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoBarras.Focus();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            decimal porcentajeAdicional, porcentajeIVA;

            if (Decimal.TryParse(txtMargenPorcentajeaAdi.Text.Replace("%", ""), out porcentajeAdicional) &&
                Decimal.TryParse(txtMargenPorcentajeIVA.Text.Replace("%", ""), out porcentajeIVA))
            {
                porcentajeAdicional /= 100;
                porcentajeIVA /= 100;

                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
                {
                    string codigo = txtCodigoBarras.Text;
                    Producto producto = BaseDeDatos.ProductosDePrueba().Find(p => p.Codigo == codigo);

                    if (producto != null)
                    {
                        // Actualiza el costo unitario
                        cpp = producto.CPP;

                        decimal costoTotal, adicional, iva, precioTotal;
                        // Llama al método CalcularValores para recalcular los valores basados en la nueva cantidad y porcentajes
                        CalcularValores(cpp, cantidad, porcentajeAdicional, porcentajeIVA, out costoTotal, out adicional, out iva, out precioTotal);

                        txtPrecioTotal.Text = precioTotal.ToString("C");
                        txtCostoTotal.Text = costoTotal.ToString("C");
                        txtMargenValorAdicional.Text = adicional.ToString("C");
                        txtMargenValorIVA.Text = iva.ToString("C");

                        //Verificar si la longitud del texto es igual a 2.
                        if (txtCantidad.Text.Length == 2)
                        {
                            // Mueve el foco al botón Agregar
                            btnAgregar.Focus();
                        }
                    }
                    else
                    {
                        MostrarError("Producto no encontrado.");
                    }
                }
                else
                {
                    // Si la cantidad no es válida, limpia los campos
                    txtCostoTotal.Text = "0";
                    txtMargenValorAdicional.Text = "0";
                    txtMargenValorIVA.Text = "0";
                    txtPrecioTotal.Text = "0";
                }
            }
            else
            {
                
            }
        }
        private void CalcularValores(decimal cpp, int cantidad, decimal porcentajeAdicional, decimal porcentajeIVA,
            out decimal costoTotal, out decimal adicional, out decimal iva, out decimal precioTotal)
        {
            costoTotal = cpp * cantidad;
            adicional = costoTotal * porcentajeAdicional;
            iva = (costoTotal + adicional) * porcentajeIVA;
            precioTotal = costoTotal + adicional + iva;
        }

        private void CalcularMontoTotal()
        {
            decimal montoTotal = 0M;

            foreach (DataGridViewRow row in dgvVentas.Rows)
            {
                if (row.Cells["PrecioTotalGrilla"].Value != null &&
                    decimal.TryParse(row.Cells["PrecioTotalGrilla"].Value.ToString(),
                    System.Globalization.NumberStyles.Currency,
                    System.Globalization.CultureInfo.CurrentCulture, out decimal precioTotalGrilla))
                {
                    montoTotal += precioTotalGrilla;
                }
            }

            txtMontoTotal.Text = montoTotal.ToString("C");
        }

        private void RecalcularValores()
        {
            decimal porcentajeAdicional, porcentajeIVA;

            if (Decimal.TryParse(txtMargenPorcentajeaAdi.Text.Replace("%", ""), out porcentajeAdicional) &&
                Decimal.TryParse(txtMargenPorcentajeIVA.Text.Replace("%", ""), out porcentajeIVA))
            {
                porcentajeAdicional /= 100;
                porcentajeIVA /= 100;

                if (int.TryParse(txtCantidad.Text, out int cantidad) && cantidad > 0)
                {
                    string codigo = txtCodigoBarras.Text;
                    Producto producto = BaseDeDatos.ProductosDePrueba().Find(p => p.Codigo == codigo);

                    if (producto != null)
                    {
                        // Actualiza el costo unitario
                        cpp = producto.CPP;

                        decimal costoTotal, adicional, iva, precioTotal;
                        // Llama al método CalcularValores para recalcular los valores basados en la nueva cantidad y porcentajes
                        CalcularValores(cpp, cantidad, porcentajeAdicional, porcentajeIVA, out costoTotal, out adicional, out iva, out precioTotal);

                        txtPrecioTotal.Text = precioTotal.ToString("C");
                        txtCostoTotal.Text = costoTotal.ToString("C");
                        txtMargenValorAdicional.Text = adicional.ToString("C");
                        txtMargenValorIVA.Text = iva.ToString("C");

                        // Mueve el foco al botón Agregar
                        btnAgregar.Focus();
                    }
                    else
                    {
                        MostrarError("Producto no encontrado.");
                    }
                }
                else
                {
                    
                }
            }
            else
            {
                
            }
        }

        private void MostrarError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbCostoUnitario_Click(object sender, EventArgs e)
        {

        }

        private void txtMargenPorcentajeAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtMargenPorcentajeaAdi.Text.Length == 2)
            {
                RecalcularValores();
            }
        }

        private void txtMargenPorcentajeIVA_TextChanged(object sender, EventArgs e)
        {
            if (txtMargenPorcentajeaAdi.Text.Length == 2)
            {
                RecalcularValores();
            }
        }

        private void txtPrecioTotal_TextChanged(object sender, EventArgs e)
        {
            RecalcularValores();
        }

        private void ReleaseObject(object obj)
        {
            try
            {
                if(obj == null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                MostrarError("Error al liberar objeto COM: " + ex.Message);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void ExportarExcel(DataGridView dgv)
        {
            try
            {
                // Crear una aplicación de Excel.
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true;

                // Agregar un nuevo libro.
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

                // Encabezados de las columnas.
                for (int columnIndex = 1; columnIndex <= dgv.ColumnCount; columnIndex++)
                {
                    worksheet.Cells[1, columnIndex] = dgv.Columns[columnIndex - 1].HeaderText;
                }

                // Datos de las celdas.
                for (int rowIndex = 0; rowIndex < dgv.RowCount; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < dgv.ColumnCount; columnIndex++)
                    {
                        object cellValue = dgv.Rows[rowIndex].Cells[columnIndex].Value;
                        worksheet.Cells[rowIndex + 2, columnIndex + 1] = cellValue != null ? cellValue.ToString() : "";
                    }
                }

                //Obtener el monto total.
                worksheet.Cells[dgv.RowCount + 2, 1] = "Monto Total:";
                worksheet.Cells[dgv.RowCount + 2, 2] = txtMontoTotal.Text;

                // Guardar el archivo como un Excel.
                workbook.SaveAs("C:\\Users\\Oxfar\\Desktop\\VentaClientesForm1.1\\Excel\\Cotización.xlsx");

                // Cerrar las librerías y sus recursos.
                workbook.Close();
                excelApp.Quit();
                ReleaseObject(worksheet);
                ReleaseObject(workbook);
                ReleaseObject(excelApp);
            }
            catch (Exception ex)
            {
                MostrarError("Error al exportar el Excel: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportarExcel(dgvVentas);
        }
    }
}
