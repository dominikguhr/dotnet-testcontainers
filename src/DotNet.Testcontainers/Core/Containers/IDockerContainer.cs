namespace DotNet.Testcontainers.Core.Containers
{
  using System;
  using System.Threading.Tasks;

  public interface IDockerContainer : IDisposable
  {
    /// <summary>Gets the Testcontainer id.</summary>
    /// <value>Returns the Docker container id if present or an empty string instead.</value>
    string Id { get; }

    /// <summary>Gets the Testcontainer name.</summary>
    /// <value>Returns the Docker container name if present or an empty string instead.</value>
    string Name { get; }

    /// <summary>Gets the Testcontainer ip address.</summary>
    /// <value>Returns the Docker container ip address if present or an empty string instead.</value>
    string IPAddress { get; }

    /// <summary>Gets the Testcontainer mac address.</summary>
    /// <value>Returns the Docker container mac address if present or an empty string instead.</value>
    string MacAddress { get; }

    /// <summary>
    /// Starts the Testcontainer. If the image does not exist, it will be downloaded automatically. Non-existing containers are created at first start.
    /// </summary>
    /// <returns>A task that represents the asynchronous start operation of a Testcontainer.</returns>
    Task StartAsync();

    /// <summary>
    /// Stops the Testcontainer and removes the container automatically.
    /// </summary>
    /// <returns>A task that represents the asynchronous stop operation of a Testcontainer.</returns>
    Task StopAsync();
  }
}
