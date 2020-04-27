using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GWOmbiBot.Database.Models
{
    public class OmbiServer
    {
        #region Database Properties
        /// <summary>
        /// Server Id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        /// <summary>
        /// A friendly name for the server to display to users
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Base url for the server
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// API key needed to access the server
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// Who owns this server
        /// </summary>
        public User Owner { get; set; }
        #endregion

        #region Non-database Properties
        /// <summary>
        /// Base url for accessing the api of the server
        /// </summary>
        [NotMapped]
        public string ApiUrl => $"{Url}/api/v1/";
        #endregion

        #region Mapped Entities
        /// <summary>
        /// Authorized server users
        /// </summary>
        public virtual List<User> Users { get; set; }
        #endregion
    }
}
