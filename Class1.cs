using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace BLL
{

    public class BusinessAccessLayer
    {
        DataAccessLayer dal = new DataAccessLayer();
        public int PropertyTypeInsert(PropertyType pt)
        {
            return dal.PropertyTypeInsert(pt);
        }

        public DataTable PropertyTypeGET()
        {
            return dal.PropertyTypeGET();
        }
        public int PropertyInsert(Property p)
        {
            return dal.PropertyInsert(p);
        }
        public int PropertyUpdate(Property p)
        {
            return dal.PropertyUpdate(p);
        }
        public DataTable PropertyGET()
        {
            return dal.PropertyGET();
        }
        public int PropertyDelete(Property p)
        {
            return dal.PropertyDelete(p);
        }
        public int ProvinceInsert(Province prov)
        {
            return dal.ProvinceInsert(prov);
        }
        public DataTable ProvinceGet()
        {
            return dal.ProvinceGet();
        }
        public int CityInsert(City c)
        {
            return dal.CityInsert(c);
        }
        public DataTable CityGet()
        {
            return dal.CityGet();
        }
        public int SuburbsInsert(Surbub s)
        {
            return dal.SuburbsInsert(s);
        }
        public DataTable SurbubGet()
        {
            return dal.SurbubGet();
        }
        public int AgenciesInsert(Agency a)
        {
            return dal.AgenciesInsert(a);
        }
        public int AgenciesDelete(Agency a)
        {
            return dal.AgenciesDelete(a);
        }
        public DataTable AgenciesGet()
        {
            return dal.AgenciesGet();
        }
        public int AgentInsert(Agent at)
        {
            return dal.AgentInsert(at);
        }
        public int AgentUpdate(Agent at)
        {
            return dal.AgentUpdate(at);
        }
        public int AgentDelete(Agent at)
        {
            return dal.AgentDelete(at);
        }
        public DataTable AgentGET()
        {
            return dal.AgentGet();
        }
        public int TenantInsert(Tenant t)
        {
            return dal.TenantInsert(t);
        }
        public int TenantUpdate(Tenant t)
        {
            return dal.TenantUpdate(t);
        }
        public int TenantDelete(Tenant t)
        {
            return dal.TenantDelete(t);
        }
        public DataTable TenantGet()
        {
            return dal.TenantGet();
        }
        public int PropertyAgentInsert(PropertyAgent pa)
        {
            return dal.PropertyAgentInsert(pa);
        }
        public int PropertyAgentUpdate(PropertyAgent pa)
        {
            return dal.PropertyAgentUpdate(pa);
        }
        public DataTable PropertyAgentGet()
        {
            return dal.PropertyAgentGet();
        }
        public int RentalInsert(Rental r)
        {
            return dal.RentalInsert(r);
        }
        public int RentaltUpdate(Rental r)
        {
            return dal.RentalUpdate(r);
        }
        public DataTable RentalGet()
        {
            return dal.RentalGet();
        }
        public int AdminInsert(Admin adm)
        {
            return dal.AdminInsert(adm);
        }
        public int AdminUpdate(Admin adm)
        {
            return dal.AdminUpdate(adm);
        }
        public int AdminHardDelete(Admin adm)
        {
            return dal.AdminUpdate(adm);
        }
        public DataTable AdminGET()
        {
            return dal.AdminGET();
        }
        public DataTable AdminLogIn(string Email,string Password)
        {
            return dal.AdminLogIn(Email,Password);
        }
        public DataTable AgentLogIn(string Email, string Password)
        {
            return dal.AgentLogIn(Email, Password);
        }
        public DataTable TenantLogIn(string Email, string Password)
        {
            return dal.TenantLogIn(Email, Password);
        }
    }
}
