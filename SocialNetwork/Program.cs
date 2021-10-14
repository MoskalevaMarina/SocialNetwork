// <copyright file="Program.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Views;

namespace SocialNetwork
{
    /// <summary>
    /// Класс Program
    /// </summary>
    public class Program
    {
        static MessageService messageService;
        static UserService userService;
        static FriendService friendService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static FriendAddView friendAddView;
        public static UserFriendView userFriendView;

        /// <summary>
        /// Метод Main
        /// </summary>
        public static void Main()
        {
            userService = new UserService();
            messageService = new MessageService();
            friendService = new FriendService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            friendAddView = new FriendAddView(friendService, userService);
            userFriendView = new UserFriendView();
            while (true)
            {
                mainView.Show();
            }
        }
    }
}