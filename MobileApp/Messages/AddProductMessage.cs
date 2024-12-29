using CommunityToolkit.Mvvm.Messaging.Messages;

namespace MobileApp.Messages;

public class AddProductMessage : ValueChangedMessage<int>
{
    public AddProductMessage(int count) : base(count)
    {
    }
}

