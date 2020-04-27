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
        /// Database Id of the server.  Cannot be set (identity_insert if off)
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; internal set; }
        /// <summary>
        /// Friendly name of the server for users / reporting
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Server url for accessing the API
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// ApiKey used when accessing the server
        /// </summary>
        public string ApiKey { get; set; }
        #endregion

        #region Non-database Properties
        /// <summary>
        /// Base url for accessing the API
        /// </summary>
        public string ApiUrl => $"{Url}/api/v1/";
        #endregion

        #region Mapping Properties
        /// <summary>
        /// Users authorized to use this server
        /// </summary>
        public virtual List<User> AuthorizedUsers { get; set; }
        /// <summary>
        /// Users with this server currently set to active
        /// </summary>
        public virtual List<User> CurrentUsers { get; set; }
        /// <summary>
        /// Groups where any user is allowed to make a request.  I don't know why they would want multiple groups yet, but assumptions are bad!
        /// </summary>
        public virtual List<Group> AuthorizedGroups { get; set; }
        #endregion
    }
}
