using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.Model
{
    internal abstract class NguoiDung
    {
        private int id;
        protected string fullname;
        protected string sodt;
        protected string vaitro;
        protected string email;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        public string SoDT
        {
            get { return sodt; }
            set { sodt = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Vaitro
        {
            get { return vaitro; }
            set { vaitro = value; }
        }
        public NguoiDung(int id, string fullname, string SoDT, string email, string vaitro)
        {
            this.id = id;
            this.fullname = fullname;
            this.sodt = SoDT;
            this.vaitro = vaitro;
            this.email = email;
        }
        public NguoiDung()
        {

        }
    }
}
