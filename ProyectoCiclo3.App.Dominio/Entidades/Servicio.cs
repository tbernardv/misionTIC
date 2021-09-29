using System;
namespace ProyectoCiclo3.App.Dominio{
    public class Servicio{
        //Definiento y encapsulando atributos
        public int id { get; set; }
        public int origen { get; set; }
        public int destino { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public int encomienda { get; set; }

    }
}