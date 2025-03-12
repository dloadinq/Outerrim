using Database.Context;
using Database.Entities;
using Repository.Repository;

namespace Repository.SpecifiedRepositories;

public class CrimeSyndicatesRepository(AircraftContext context) : ARepository<CrimeSyndicate>(context) { }