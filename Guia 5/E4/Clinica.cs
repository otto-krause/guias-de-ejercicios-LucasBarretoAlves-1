using System;
using System.Linq;
using System.Collections.Generic;
namespace E4
{
    public class Clinica
    {
        List<Medico> medicos;
        List<Medico> medicosdisponibles;
        Medico carlosperez;
        Medico juanagomez;
        Medico auxiliar;
        public Clinica ()
        {
            medicos = new List<Medico> ();
            carlosperez = new Medico ("Carlos", "Perez", "Odontologia", 45);
            juanagomez = new Medico ("Juana", "Gomez", "Eutanasiologia", 200);
            medicos.Add (carlosperez);
            medicos.Add (juanagomez);
        }
        public Medico buscarMedico (string especialidad)
        {
            medicosdisponibles=medicos.Where(medico => medico.EstaDisponibleYCumpleEspecialidad(especialidad)).ToList();
            return auxiliar = medicosdisponibles.Count() > 0 ? medicosdisponibles.First() : null;
        }

    }
}