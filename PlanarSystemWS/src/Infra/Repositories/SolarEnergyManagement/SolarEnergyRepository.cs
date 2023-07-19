using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Repositories.SolarEnergyManagement;

public class SolarEnergyRepository : ISolarEnergyRepository
{
    private readonly MySqlDbContext _context;

    public SolarEnergyRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task SaveBudgetForm(RefBudgetForm budgetForm)
    {
        try
        {
            await _context.BudgetForms.AddAsync(budgetForm);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task<RefBudgetForm> FindBudgetFormById(Guid id)
    {
        try
        {
            var budgetForm = await _context.BudgetForms.FirstOrDefaultAsync(x => x.Id.Equals(id));

            return budgetForm;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateBudgetForm(RefBudgetForm origin, RefBudgetForm updated)
    {
        try
        {
            _context.Attach(updated);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }
}
