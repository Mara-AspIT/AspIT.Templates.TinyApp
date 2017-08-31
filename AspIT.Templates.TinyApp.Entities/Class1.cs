/**************************************************************************************************
*  Author: Mads Mikkel Rasmussen (mara@aspit.dk), github: https://github.com/Mara-AspIT/          *
*  Solution: .NET version: 4.6.2, C# version: 7.0                                                 *
*  Repository: https://github.com/Mara-AspIT/AspIT.Templates.TinyApp                              *
*  Visual Studio version: Visual Studio Enterprise 2017, version 15.2.                            *
**************************************************************************************************/

using System;

namespace AspIT.Templates.TinyApp.Entities
{
    /// <summary>Represents the user credentials of a user.</summary>
    public struct UserCredentials
    {

        #region Fields
        /// <summary>Error message to pass as argument to exceptions.</summary>
        private const string complianceError = "Does not comply with rules";

        /// <summary>The password of the user.</summary>
        private string password;

        /// <summary>The username of the user.</summary>
        private string username;
        #endregion


        #region Constructors
        /// <summary>Creates a new object of <see cref="UserCredentials"/> with the specified username and password.</summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <exception cref="ArgumentException">Thrown when either username or password does not conform to rules.</exception>
        public UserCredentials(string username, string password)
        {
            if(!IsUsernameValid(username))
                throw new ArgumentException(complianceError, nameof(username));
            else if(!IsPasswordValid(password))
                throw new ArgumentException(complianceError, nameof(password));
            this.username = username;
            this.password = password;
        }
        #endregion


        #region Methods
        /// <summary>Determines whether a password is valid or not, according to the rules.</summary>
        /// <param name="password">The password to validate.</param>
        /// <returns>A <see cref="bool"/> indicating whether or not the provided password conforms to the rules.</returns>
        public static bool IsPasswordValid(string password)
        {
            if(String.IsNullOrWhiteSpace(password))
                return false;
            else
                throw new NotImplementedException();
        }

        /// <summary>Determines whether a username is valid or not, according to the rules.</summary>
        /// <param name="username">The username to validate.</param>
        /// <returns>A <see cref="bool"/> indicating whether or not the provides username conforms to the rules.</returns>
        public static bool IsUsernameValid(string username)
        {
            if(String.IsNullOrWhiteSpace(username))
                return false;
            else
                throw new NotImplementedException();
        }

        /// <summary>Returns a textual representation of the object's current state.</summary>
        /// <returns>A <see cref="string"/> with the username of this <see cref="UserCredentials"/>.</returns>
        public override string ToString() => $"Username: {username}.";      // This is C# 7 syntax. There's no { } and => means return.       
        #endregion


        #region Properties
        /// <summary>Gets or set the password of the user.</summary>
        /// <value>The password to validate.</value>
        /// <exception cref="ArgumentException">Thrown when the provided value does not conform to rules.</exception>
        public string Password
        {
            get => password;    // This is C# 7 syntax. There's no { } and => means return.
            set
            {
                if(!IsPasswordValid(value))
                    throw new ArgumentException(complianceError, "Mutator in " + nameof(Password));
                password = value;
            }
        }

        /// <summary>Gets or set the username of the user.</summary>
        /// <value>The username to validate.</value>
        /// <exception cref="ArgumentException">Thrown when the provided value does not conform to rules.</exception>
        public string Username
        {
            get => username;    // This is C# 7 syntax. There's no { } and => means return.
            set
            {
                if(!IsUsernameValid(value))
                    throw new ArgumentException(complianceError, "Mutator in " + nameof(Username));
                username = value;
            }
        }
        #endregion
    }
}

/* Username rules: A username must consist of letter only and be at least 4 characters long and at most 10 characters long. The first character must be capital.
 * Password Rules: A password must be  */
