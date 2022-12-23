using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVCApplication.Services
{
    public interface Repo<K>
    {
        public bool Validate(K k);
    }
}
