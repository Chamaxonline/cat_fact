using Client.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services.Interface
{
    public interface ICatService
    {
        Task<FactViewModel> Get();
    }
}
