namespace ePizza.WebApi.Model
{
    using System;

    public class Auditable
    {
        long CreatedBy { get; set; }
        DateTime Created { get; set; }
        long UpdatedBy { get; set; }
        DateTime Updated { get; set; }
    }
}
