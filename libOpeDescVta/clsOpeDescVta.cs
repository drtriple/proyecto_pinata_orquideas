using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referenciar y Usar 
using libRnDescVta;

namespace libOpeDescVta
{
    public class clsOpeDescVta
    {
        #region "Atributos"
        private int intCod;
        private int intCant;
        private float fltVrDoc;
        private float fltPorcIva;
        private float fltSubTot;
        private float fltPorcDscto;
        private float fltVrDscto;
        private float fltVrIVA;
        private float fltTotAPag;
        private String strError;

      
        #endregion

        #region Constructor
        public clsOpeDescVta()
        {
             intCod = 0;
             intCant = 0;
             fltVrDoc = 0;
             fltPorcIva = 0;
             fltSubTot = 0;
             fltPorcDscto = 0;
             fltVrDscto = 0;
             fltVrIVA = 0;
             fltTotAPag = 0;
             strError = string.Empty;
        }
        #endregion

        #region "Propiedades"

        //Entradas

        public int Codigo  //Codigo
        {
            set {  intCod = value; }
        }
        public int Cantidad//Cantidad
        {
            set {  intCant = value; }
        }
        public float vrDocena //Docena
        {
            set { fltVrDoc = value; }
        }

        public float porcIva //IVA
        {
            set {  fltPorcIva = value; }
        }

        //Salidas

        public float subTotal //Subtotal
        {
            get { return fltSubTot; }
        }
        
         public float porcDscto //Porcentaje de Descuento
        {
            get { return porcDscto; }
        }

        public int vrDscto  //Valo Descuento
        {
           get { return vrDscto; }
        }

        public float vrIVA //Valor IVA
        {
            get { return vrIVA; }
        }

        public float totalAPagar //Total A Pagar
        {
          get { return totalAPagar; }
        }

        public string Error //Error
        {
            get { return strError; }
            //set { strError = value; }
        }
        #endregion

        #region "Metodos Privados"
        private bool Validar()
        {
            if (intCod <= 0)                                                    //  Código
            {
                strError = "Código no Válido";
                return false;                 //Detiene el programa en el primer error que encuentre
            }
            if (intCant <= 0)                                                  //Cantidad
            {
                strError = "La cantidad de unidades no es Válida";  
                return false;
            }
            if (fltVrDoc <= 0)                                                   //Docena
            {
                strError = "El  valor de la docena no es válida";
                return false;
            }
            if (fltPorcIva <= 0 || fltPorcIva > 19)                      //Porcentaje IVA
            {
                strError = "El porcentaje del IVA no es válido";
                return false;
            }
           return true;    
        }
        #endregion


                #region "Metodos Publicos"
        public bool Facturar()
        {
            try
            {
                if (!Validar())   //Si validar devuelve false entonces no hay nada que facturar por lo tanto "Facturar" también devuelve false
                    return false;

                //Crear el Objeto RN
                clsRnDescVta rN = new clsRnDescVta();  //Crea un objeto de la clase clsRnDescVta que esta en otro espacio de nombre pero ya lo referenciamos y el using esta al principio del codigo para no tener que escribir el espacio de nombre todo el tiempo

                //Enviar Información a RN
                rN.Codigo = intCod;

                //Invocación y Tratamiento del Error
                rN.hallarDscto();
                //Recuperar Información 

                //Procesar 
                fltSubTot = intCant * fltVrDoc;
                fltVrDscto = (fltPorcDscto / 100) * fltSubTot;
                fltVrIVA = ((fltSubTot - fltVrDscto) * fltPorcIva) / 100;
                fltTotAPag = fltSubTot - fltVrDscto + fltVrIVA;


                return true;

            }
            catch (Exception ex) 
            {
                 strError = " Error en facturar " ;
                return false;   
            }
        }
        #endregion
    }
}
