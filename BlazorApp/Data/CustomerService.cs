namespace BlazorApp.Data
{
    public class CustomerService
    {
        private readonly CustomerDataAccessLayer objCustomerDAL; // Declare objCustomerDAL

        public CustomerService()
        {
            objCustomerDAL = new CustomerDataAccessLayer(); // Instantiate objCustomerDAL
        }
        public string Create(CustomerInfo objCustomer)
        {
            objCustomerDAL.AddCustomer(objCustomer);
            return "Added Successfully";
        }
        public List<CustomerInfo> GetCustomer()
        {
            List<CustomerInfo> customers = objCustomerDAL.GetAllCustomers().ToList();
            return customers;
        }
        public CustomerInfo GetCustomerByID(int id)
        {
            CustomerInfo customer = objCustomerDAL.GetCustomerData(id);
            return customer;
        }
        public string UpdateCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.UpdateCustomer(objcustomer);
            return "Update Successfully";
        }
        public string DeleteCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.DeleteCustomer(objcustomer.CustomerId);
            return "Delete Successfully";
        }
    }
}
