using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GWOmbiBot.Database.Models
{
    public class User
    {
        #region Database Properties
        /// <summary>
        /// Database Id of the user.  Cannot be set (identity_insert if off)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; internal set; }
        /// <summary>
        /// Telegram Id of the user
        /// </summary>
        public int TelegramId { get; set; }
        /// <summary>
        /// Friendly name of the user for reporting purposes
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Mapping Properties
        public virtual List<OmbiServer> AuthorizedServers { get; set; }
        public virtual OmbiServer CurrentServer { get; set; }
        #endregion
    }
}
