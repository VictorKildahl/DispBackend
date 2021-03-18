using F20ITONK.ASPNETCore.MicroService.ClassLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Data
{
    public static class HaandvaerkerDbContextExtensions 
    {
        public static void EnsureDatabaseSeeded(this HaandvaerkerContext context)
        {
            context.Database.EnsureCreated();

            var hv = new Haandvaerker()
            {
                HaandvaerkerId = 1,
                HVAnsaettelsedato = DateTime.Now.Date,
                HVEfternavn = "Jensen",
                HVFornavn = "Jesper",
                HVFagomraade = "Murer",

            };
            var vt = new Vaerktoejskasse()
            {
                VTKId = 1,
                VTKAnskaffet = new DateTime(2019, 9, 1),
                VTKFabrikat = "Stanley",
                VTKFarve = "Blå",
                VTKModel = "Premium",
                VTKSerienummer = "11",
            };

            var v = new Vaerktoej()
            {
                VTAnskaffet = new DateTime(2019, 9, 1),
                VTFabrikat = "Fiskars",
                VTId = 1,
                VTModel = "Lille",
                VTSerienr = "112",
                VTType = "Hammer"
            };

            context.Vaerktoej.Add(v);
            vt.Vaerktoej.Add(v);
            context.Vaerktoejskasse.Add(vt);
            hv.Vaerktoejskasse.Add(vt);
            context.Add(hv);
            context.SaveChanges();
        }
    }
}
