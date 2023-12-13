using BlazorApp.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class InstrumentDataAccessLayer
    {
        private readonly string connectionString;

        public InstrumentDataAccessLayer(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DbConnectionString");
        }

        public IEnumerable<InstrumentInfo> GetAllInstruments()
        {
            List<InstrumentInfo> instrumentList = new List<InstrumentInfo>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetAllInstruments", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    InstrumentInfo instrument = new InstrumentInfo();
                    instrument.ID = Convert.ToInt32(rdr["ID"]);
                    instrument.Name = rdr["Name"].ToString();
                    instrument.TypeInstrument = rdr["TypeInstrument"].ToString();
                    instrument.Condition = rdr["Condition"].ToString();
                    instrument.Price = Convert.ToDecimal(rdr["Price"]);
                    instrument.Description = rdr["Description"].ToString();
                    instrument.Year = Convert.ToDateTime(rdr["Year"]);
                    instrument.Color = rdr["Color"].ToString();
                    instrument.Material = rdr["Material"].ToString();
                    instrumentList.Add(instrument);
                }
            }
            return instrumentList;
        }

        // To Add a new Instrument record
        public void AddInstrument(InstrumentInfo instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("AddInstrument", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", instrument.Name);
                cmd.Parameters.AddWithValue("@TypeInstrument", instrument.TypeInstrument);
                cmd.Parameters.AddWithValue("@Condition", instrument.Condition);
                cmd.Parameters.AddWithValue("@Price", instrument.Price);
                cmd.Parameters.AddWithValue("@Description", instrument.Description);
                cmd.Parameters.AddWithValue("@Year", instrument.Year);
                cmd.Parameters.AddWithValue("@Color", instrument.Color);
                cmd.Parameters.AddWithValue("@Material", instrument.Material);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // To Update the records of a particular Instrument
        public void UpdateInstrument(InstrumentInfo instrument)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UpdateInstrument", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", instrument.Name);
                cmd.Parameters.AddWithValue("@TypeInstrument", instrument.TypeInstrument);
                cmd.Parameters.AddWithValue("@Condition", instrument.Condition);
                cmd.Parameters.AddWithValue("@Price", instrument.Price);
                cmd.Parameters.AddWithValue("@Description", instrument.Description);
                cmd.Parameters.AddWithValue("@Year", instrument.Year);
                cmd.Parameters.AddWithValue("@Color", instrument.Color);
                cmd.Parameters.AddWithValue("@Material", instrument.Material);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Get the details of a particular Instrument
        public InstrumentInfo GetInstrumentData(int? id)
        {
            InstrumentInfo instrument = new InstrumentInfo();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("GetInstrumentByID", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    instrument.ID = Convert.ToInt32(rdr["ID"]);
                    instrument.Name = rdr["Name"].ToString();
                    instrument.TypeInstrument = rdr["TypeInstrument"].ToString();
                    instrument.Condition = rdr["Condition"].ToString();
                    instrument.Price = Convert.ToDecimal(rdr["Price"]);
                    instrument.Description = rdr["Description"].ToString();
                    instrument.Year = Convert.ToDateTime(rdr["Year"]);
                    instrument.Color = rdr["Color"].ToString();
                    instrument.Material = rdr["Material"].ToString();
                }
            }
            return instrument;
        }

        // To Delete the record of a particular Instrument
        public void DeleteInstrument(int? id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DeleteInstrument", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
