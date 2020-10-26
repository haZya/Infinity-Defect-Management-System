namespace Infinity
{
    public static class FormProvider
    {
        private static LoginForm _login;
        private static Dashboard _dashboard;

        /// <summary>
        /// Getting an instance of LoginForm
        /// </summary>
        public static LoginForm Login
        {
            get
            {
                if (_login == null)
                {
                    _login = new LoginForm();
                }
                return _login;
            }
        }

        /// <summary>
        /// Getting an instance of Dashboard form
        /// </summary>
        public static Dashboard Dashboard
        {
            get
            {
                if (_dashboard == null)
                {
                    _dashboard = new Dashboard();
                }
                return _dashboard;
            }
        }
    }
}
