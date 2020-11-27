using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IUsable
{
    int charges { get; set; }
    public bool used();

    public abstract string Use(IUsable used, int num);
    

}