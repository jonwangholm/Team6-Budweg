﻿using System;
using Budweg.MVVM.Models;
using Budweg.MVVM.ViewModels.Persistence;

namespace Budweg.MVVM.ViewModels
{
    public class MessageViewModel
    {
        private Message source;

        public int MessageId { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }

        public MessageViewModel(Message source)
        {
            this.source = source;

            MessageId = source.MessageId;
            Content = source.Content;
            SendTime = source.SendTime;
        }

        public void Delete()
        {
            throw new NotImplementedException();
            // RepositoryManager.MessageRepository.Delete(source);
        }
    }
}
