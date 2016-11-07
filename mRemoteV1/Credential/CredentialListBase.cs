﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace mRemoteNG.Credential
{
    public class CredentialListBase : List<ICredentialRecord>, ICredentialList
    {
        public ICredentialRecord GetCredential(Guid uniqueId)
        {
            return this.FirstOrDefault(cred => cred.UniqueId == uniqueId);
        }

        public bool Contains(Guid uniqueId)
        {
            return Count != 0 && Exists(cred => cred.UniqueId == uniqueId);
        }
    }
}