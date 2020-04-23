using System;
using System.Collections.Generic;
namespace E2
{
    public class Clinica
    {
        public List<Medico> medicos =new List<Medico>();
        Medico carlosperez = new Medico("Carlos", "Perez", "Odontologia", 45);
        Medico juanagomez = new Medico("Juana", "Gomez", "Eutanasiologia", 200);      
        public Clinica ()
        {
            medicos.Add(carlosperez);
            medicos.Add(juanagomez);
        }

    }
}