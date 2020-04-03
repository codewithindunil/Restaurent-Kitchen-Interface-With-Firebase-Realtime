
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kitchen
{
    class Firebase
    {
        static IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "lJ00CGCubk8WK0tl0zD2ZUULDmVkUfVA1fXqqs0V",
            BasePath = "https://c-sharp-2a4aa.firebaseio.com/"
        };

        IFirebaseClient client = new FireSharp.FirebaseClient(config);
        


        
    }
}
