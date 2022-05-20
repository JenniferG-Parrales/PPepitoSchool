using PepitoSchool.Domain.Entities;
using PepitoSchool.Domain.Interfaces;
using PepitoSchool.Domain.PepitoSchoolDBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PepitoSchool.Infraestructura.Repository
{
    public class EFEstudianteRepository : IEstudianteRepository
    {
        public PepitoSchoolContext estudianteDBContext;

        public EFEstudianteRepository(PepitoSchoolContext estudianteDBContext)
        {
            this.estudianteDBContext = estudianteDBContext;
        }

        public void create(Estudiante t)
        {
            try
            {
                estudianteDBContext.Estudiantes.Add(t);
                estudianteDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Estudiante t)
        {
            try
            {
                estudianteDBContext.Estudiantes.Remove(t);
                estudianteDBContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Estudiante FindById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new Exception($"El id {id} no puede ser menor o igual a cero.");
                }

                return estudianteDBContext.Estudiantes.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Estudiante> Read()
        {
            try
            {
                return estudianteDBContext.Estudiantes.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void IRepository<Estudiante>.Create(Estudiante t)
        {
            throw new NotImplementedException();
        }

        bool IRepository<Estudiante>.Delete(Estudiante t)
        {
            throw new NotImplementedException();
        }

        Estudiante IEstudianteRepository.FindByCarnet(string carnet)
        {
            throw new NotImplementedException();
        }

        List<Estudiante> IEstudianteRepository.FindByLastnames(string lastnames)
        {
            throw new NotImplementedException();
        }

        List<Estudiante> IEstudianteRepository.FindByNames(string names)
        {
            throw new NotImplementedException();
        }

        List<Estudiante> IRepository<Estudiante>.GetAll()
        {
            throw new NotImplementedException();
        }

        int IRepository<Estudiante>.Update(Estudiante t)
        {
            throw new NotImplementedException();
        }
    }
}
