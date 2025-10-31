using AuthService.Application.Dto.UserDataTransferObjects;
using AuthService.Application.Features.Users.Handlers.Commands;
using AuthService.Application.Features.Users.Requests.Commands;
using AuthService.Application.Interfaces.Auth;
using AuthService.Application.Interfaces.Repositories;
using AuthService.Domain.Entities;
using Moq;

namespace AuthService.Unit.Handlers.UserHandlers;

public class CreateUserCommandHandlerTests
{
    [Fact]
    public async Task Handler_Should_Create_User()
    {
        //Arrange
        var repoMock = new Mock<IUserRepository>();
        var hasherMock = new Mock<IPasswordHasher>();
        var uowMock = new Mock<IUnitOfWork>();
        
        var cancellationToken = CancellationToken.None;

        var userDto = new UserCreateDto("testName", "testEmail", "testPassword");

        repoMock.Setup(r => r.CreateAsync(It.IsAny<User>(), cancellationToken));
        hasherMock.Setup(r => r.GenerateHash(userDto.Password));
        uowMock.Setup(u => u.SaveChangesAsync(cancellationToken));

        var handler = new CreateUserCommandHandler(repoMock.Object, hasherMock.Object, uowMock.Object);

        var request = new CreateUserCommand { UserDto = userDto };

        //Act
        await handler.Handle(request, cancellationToken);

        //Assert
        repoMock.Verify(r => r.CreateAsync(It.IsAny<User>(), cancellationToken), Times.Once);
        hasherMock.Verify(r => r.GenerateHash(userDto.Password), Times.Once);
        uowMock.Verify(u => u.SaveChangesAsync(cancellationToken), Times.Once);
    }
}