using System;
using System.Collections.Generic;
using System.Text;

namespace GWOmbiBot.Database.Models
{
    public class User
    {
        #region Database Properties
        /// <summary>
        /// Telegram Id of the user
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Users name, for reporting purposes
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Mapped Properties
        /// <summary>
        /// Server user is allowed to access, if any
        /// </summary>
        public virtual OmbiServer Server { get; set; }
        #endregion
    }
}
