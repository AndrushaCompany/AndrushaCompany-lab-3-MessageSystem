using System;
using Itmo.ObjectOrientedProgramming.Lab3.Adressee;
using Itmo.ObjectOrientedProgramming.Lab3.Message;
using Itmo.ObjectOrientedProgramming.Lab3.Messenger;
using Moq;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab3.Tests;

public class Tests
{
        [Fact]
        public void MessageIsSavedAsUnread()
        {
            // Arrange
            var messageBuilder = new MessageBuilder();
            var user = new User.User(messageBuilder, 1);
            var message = new Message.Message("Test Heading", "Test Main Body", 1);

            // Act
            user.MessageSending(message);

            // Assert
            Assert.False(user.GetMessage(0).Read);
        }
        
        [Fact]
        public void MarkMessageAsRead()
        {
            // Arrange
            var messageBuilder = new MessageBuilder();
            var user = new User.User(messageBuilder, 1);
            var message = new Message.Message("Test Heading", "Test Main Body", 1);
            user.MessageSending(message);

            // Act
            user.ChangeToRead(message);

            // Assert
            Assert.True(user.GetMessage(0).Read);
        }
        
        [Fact]
        public void MarkMessageAsReadWhenAlreadyReadShouldReturnError()
        {
            // Arrange
            var messageBuilder = new MessageBuilder();
            var user = new User.User(messageBuilder, 1);
            var message = new Message.Message("Test Heading", "Test Main Body", 1);
            user.MessageSending(message);

            // Act
            user.ChangeToRead(message);

            // Assert
            Assert.Throws<InvalidOperationException>(() => user.ChangeToRead(message));
        }
        
        [Fact]
        public void MessageSendingWithFilterAndLowRelevanceLevelShouldNotReachAdressee()
        {
            // Arrange
            var mockAdressee = new Mock<IAdressee>();
            var adresseeFilter = new AdresseeFilter(mockAdressee.Object, 5); // Minimal relevance level is 5
            var message = new Message.Message("Test Heading", "Test Main Body", 3); // Relevance level is 3

            // Act
            adresseeFilter.MessageSending(message);

            // Assert
            mockAdressee.Verify(a => a.MessageSending(It.IsAny<Message.Message>()), Times.Never);
        }
        
        [Fact]
        public void MessageSendingWithLoggingShouldWriteLog()
        {
            // Arrange
            var mockAdressee = new Mock<IAdressee>();
            var adresseeLog = new AdresseeLog(mockAdressee.Object);
            var message = new Message.Message("Test Heading", "Test Main Body", 5);

            // Act
            adresseeLog.MessageSending(message);

            // Assert
            mockAdressee.Verify(a => a.MessageSending(It.IsAny<Message.Message>()), Times.Once);
            // Verify that the Logging method was called with the correct message
            mockAdressee.Verify(a => a.Logging(message), Times.Once);
        }
        
        [Fact]
        public void SendMessageShouldCallShowText()
        {
            // Arrange
            var mockMessenger = new Mock<IMessenger>();
            var message = "Test message";
            var messenger = new Messenger.Messenger("TestMessenger");

            // Act
            messenger.SendMessege(message);

            // Assert
            mockMessenger.Verify(m => m.ShowText(message), Times.Once);
        }
        
        
    
}