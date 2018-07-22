using System;
using System.Collections.Generic;
using System.Text;

namespace IconLibrary
{
    class Settings
    {
        protected CachedStorage storage;

        protected Settings()
        {
            storage = new CachedStorage();
        }

        public void Reload()
        {
            storage.Reload();
        }
    }
}
