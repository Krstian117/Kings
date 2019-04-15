using Datos;
using Dominio;
using Negocio.Conexion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio.Validaciones
{
    public class ValidationsDocumentType : Datamodel
    {
        public IEnumerable<DocumentType> GetAllDocumentTypes()
        {
            try
            {
                return db.DocumentType.OrderByDescending(x => x.Name);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
