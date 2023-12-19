using BlazorApp.Data;
using BlazorApp.Model;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace BlazorApp.Data
{
    public class InstrumentService
    {
        private readonly InstrumentDataAccessLayer objInstrumentDAL;

        public InstrumentService(IConfiguration configuration)
        {
            objInstrumentDAL = new InstrumentDataAccessLayer(configuration);
        }

        public string Create(InstrumentInfo objInstrument)
        {
            objInstrumentDAL.AddInstrument(objInstrument);
            return "Added Successfully";
        }

        public List<InstrumentInfo> GetInstruments()
        {
            List<InstrumentInfo> instruments = objInstrumentDAL.GetAllInstruments().ToList();
            return instruments;
        }

        public InstrumentInfo GetInstrumentByID(int id)
        {
            InstrumentInfo instrument = objInstrumentDAL.GetInstrumentData(id);
            return instrument;
        }

        public string UpdateInstrument(InstrumentInfo objInstrument)
        {
            objInstrumentDAL.UpdateInstrument(objInstrument);
            return "Update Successfully";
        }

        public string DeleteInstrument(InstrumentInfo objInstrument)
        {
            objInstrumentDAL.DeleteInstrument(objInstrument.ID);
            return "Delete Successfully";
        }

        public Product GetOneProduct(int id)
        {
            if (id == 0)
            {
                return null;
            }
            return objInstrumentDAL.GetOneProduct(id);
        }
        public async Task GetInstrumentsByType(string instrumentType)
        {
            await objInstrumentDAL.GetInstrumentsByType(instrumentType);
        }
    }
}