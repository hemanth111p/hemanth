using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class RDSDataModel
    {
        private string counterpartyId;
        private string name;

        public string Getname() { return this.name; }
        public string GetcounterpartyId() { return this.counterpartyId; }
        public void Setname(string value) { this.name = value; }
        public void SetcounterpartyId(string value) { this.counterpartyId = value; }
    }
}
