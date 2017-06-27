using System.Data.Entity.ModelConfiguration.Conventions;

namespace EscaliTest.DataAccess
{
    internal class SeqAsIdConvention : Convention
    {
        public SeqAsIdConvention()
        {
            this.Properties().Where(p => p.Name.EndsWith("Seq")).Configure(p => p.IsKey());
        }
    }
}