using ReimModelsLayer;
using RepoAcessLayer;
namespace BusinessLayer;
public class ReimbursementbusiLayer
{
    private RepoLayer _rep;

    public ReimbursementbusiLayer()
    {
        this._rep = new RepoLayer();
    }
    public async Task<List<Request>> RequestAsync(string type)
    {

    
    }
}

