using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class studentinfo
    {
#region state - private
        private string id;
        private string name;
        private int marks;
        #endregion

#region behavious , public interfaces / nutrators message passing
        public string GetId() { return this.id; }
        public string GetName() { return this.name; }
        public int Getmarks() { return this.marks; }
        public void SetId(string value) { this.id = value; }
        public void Setname(string value) { this.name = value; }
        public void Setmarks(int value) { this.marks = value; }
#endregion
    } 
}
