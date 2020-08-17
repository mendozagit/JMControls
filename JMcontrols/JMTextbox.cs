using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JMcontrols
{

    [ProvideProperty("JMTextbox", typeof(Control))]
    public sealed class JMTextbox : TextBox
    {
        #region Members


        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Si el valor es true, entonces el control aceptará solo numeros, en caso contrario cualquier string. Valor por defecto false."), Category("Behavior")]
        [DisplayName("IsNumerical"), DefaultValue(false)]
        public bool IsNumerical
        {
            get { return _isNumerical; }
            set { _isNumerical = value; }
        }
        private bool _isNumerical;



        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Recupera el valor de la propiedad Text, hace la conversíon a decimal y retorna el valor. Valor por defecto 0."), Category("Behavior")]
        [DisplayName("Value"), DefaultValue(0)]
        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private decimal _value;



        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Establece las posiciones decimales para la propiedad Value, siempre que la propiedad IsNumerical sea true. Valor por defecto es 2."), Category("Behavior")]
        [DisplayName("Thousands Separator"), DefaultValue(false)]
        public int PosicionesDecimales
        {
            get { return _posicionesDecimales; }
            set { _posicionesDecimales = value; }
        }
        private int _posicionesDecimales;

        private bool _thousandsSeparator;



        #endregion

        #region Constructors
        public JMTextbox()
        {

        }

        public JMTextbox(IContainer container) : this() { container.Add(this); }

        #endregion

        #region PreInitialized Events



        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

        protected override void OnKeyPress(KeyPressEventArgs e)
        {

            base.OnKeyPress(e);

            if (IsNumerical)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    e.Handled = true;


                // only allow one decimal point
                if (e.KeyChar == '.' && Text.IndexOf('.') > -1)
                    e.Handled = true;
            }
        }


        //protected override void OnKeyPress(KeyPressEventArgs e )
        //{
        //    base.OnKeyPress(e);
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
        //        e.Handled = true;


        //    // only allow one decimal point
        //    if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
        //    {
        //        e.Handled = true;
        //    }
        //}



        #endregion

    }
}
