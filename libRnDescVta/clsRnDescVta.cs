using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace libRnDescVta
{
    public class clsRnDescVta
    {
        #region " Atributos"
        private int intCod;
        private int intCant;
        private float fltDesc;
        private String strError;
        #endregion

        #region " Constructor"
        public  clsRnDescVta()
    { 
          intCod = 0;
          intCant = 0;
          fltDesc =0 ;
          strError = string.Empty;
        }
        #endregion

        #region " Propiedades"
        public int Codigo   //1Codigo
        {
            set => intCod = value;
        }
        public int Cantidad   //2Cantidad
        {
             set => intCant = value;
        }
        public float Descuento   //3Descuento
        {
            get => fltDesc;
            //get {return fltDesc;}    Otra forma de hacerlo
        }

        public string Error   //4Error
        {
            get => strError;        
        }
        #endregion

        #region "Metodos Privados "
        private bool Validar() 
        {
            if (intCod <= 0)
            {
                strError = "Código no Válido";
                return false;   
            }
            return true;
        }
        private bool leerArchivo()
        {
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt"; //Construye la ruta completa del archivo "Descuentos.txt", asegurándose de que esté en la misma carpeta donde se ejecuta el programa.
                int intCantReg = 0, intCodLeido, intCantLeido;
                float fltPorcLeido;
                string strLinea;
                string[] vectorCodLinea;
                intCantReg = File.ReadAllLines(strPath).Length; //Cuenta cuántas líneas tiene el archivo.
                if (intCantReg <= 0) //Garantiza que el programa no intente leer un archivo vacío
                    return true; //Termina el proceso
                StreamReader Archivo = new StreamReader(@strPath); //Objeto para leer el archivo
                while ((strLinea = Archivo.ReadLine()) != null ) //Leer línea * línea (cuando llega al final devuelve un "null" que es capturado en la condición para salir del programa)
                {        vectorCodLinea = strLinea.Split(':');//Separa la cadena de texto y las devuelve en un array que luego se va ir guardando en las siguientes variables
                   
                    intCodLeido = Convert.ToInt32(vectorCodLinea[0]);   //Código del producto
                    intCantLeido = Convert.ToInt32(vectorCodLinea[1]);  //Cantidad mínima
                    fltPorcLeido = Convert.ToSingle(vectorCodLinea[2]); //Promedio de descuento

                    if (intCod == intCodLeido && intCant > intCantLeido)  //Cálcula si aplica para el descuento o no
                    {                   //NOTA: "Leido" es la información que esta en el archivo "Descuento.txt"
                        fltDesc = fltPorcLeido; //Porcentaje del dscto, envía un cero si no encuentra nada
                        Console.WriteLine("No tiene descuento");
                        break;//Rompe el ciclo while porque ya se encontró el descuento
                    }
               }
                Archivo.Close(); //Cierra el archivo (Cerrarlo evita desperdiciar memoria y mejora el rendimiento del programa.)
                return true;
            }
            catch (Exception ex) //Captura cualquier tipo de error gracias a "Exception"
            {
                strError = ex.Message;//Guarda el mensaje de error (para mostrarlo en otro momento)
                return false; //Indica que la función falló,
            }
        }
        #endregion

        #region "Metodos Publicos "
        public bool hallarDscto()
        {
            if (!Validar())
                return false;
            return leerArchivo();  //Evita operaciones innecesarias, asegurando que solo se lee el archivo cuando los datos cumplen ciertos requisitos.
        }

        #endregion
 
    }
}