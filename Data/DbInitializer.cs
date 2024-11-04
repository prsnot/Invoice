using Invoice.Models;

namespace Invoice.Data
{
    public static class DbInitializer
    {
        public static void Initialize(InvoiceContext context)
        {
            context.Database.EnsureCreated();
            if (context.Invoice.Any()) {
                return;
            }
            //var companies = new CompanyModel[]
            //    {
            //        new CompanyModel(Name="Comp1",Password="P@ssword"),
            //        new CompanyModel(Name="Comp2",Password="P@ssword")
            //};
            //foreach (CompanyModel c in companies){
            //    context.Company.Add(c);
            //}
            //context.SaveChanges();

            //var i = new CompanyModel[]
            //    {
            //        new CompanyModel(Name="Comp1",Password="P@ssword"),
            //        new CompanyModel(Name="Comp2",Password="P@ssword")
            //};
            //foreach (CompanyModel c in companies)
            //{
            //    context.Company.Add(c);
            //}
        }
    }
}
