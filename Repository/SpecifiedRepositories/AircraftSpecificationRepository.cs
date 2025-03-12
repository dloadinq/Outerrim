using Database.Context;
using Database.Entities;
using Repository.Repository;

namespace Repository.SpecifiedRepositories;

public class AircraftSpecificationRepository(AircraftContext context) : ARepository<AircraftSpecification>(context) { }