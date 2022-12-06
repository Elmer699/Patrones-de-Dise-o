using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampObserver
{
    public class Docente : ISujetoCamp
    {
        private bool _noti = false;

        public Docente(bool noti)
        {
            this._noti = noti;
        }

        private List<ICamp> _usuario = new List<ICamp>();

        public void Agregar(ICamp camp)
        {
            this._usuario.Add(camp);
        }

        public void Notificar()
        {
            foreach(var usuario in _usuario)
            {
                usuario.Update(this);
            }
        }

        public void Quitar(ICamp camp)
        {
            this._usuario.Remove(camp);
        }
        public bool Noticias
        {
            get { return _noti; }
            set
            {
                if (_noti != true)
                {
                    _noti = true;
                    this._noti = value;

                }
            }
        }
    }
}
