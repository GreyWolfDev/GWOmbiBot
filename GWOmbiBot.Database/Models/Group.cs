using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GWOmbiBot.Database.Models
{
    public class Group
    {
        #region Database Properties
        /// <summary>
        /// Database Id of the group.  Cannot be set (identity_insert if off)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// Telegram Id of the group
        /// </summary>
        public long TelegramId { get; set; }
        /// <summary>
        /// Friendly name for reporting purposes
        /// </summary>
        public string Name { get; set; }
        #endregion

        #region Mapping Properties
        /// <summary>
        /// Server the group is mapped to.  Only one server per group, to prevent confusion from users.
        /// </summary>
        public virtual OmbiServer Server { get; set; }
        #endregion
    }
}
