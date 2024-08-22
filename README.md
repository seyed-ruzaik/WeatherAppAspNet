
# WeatherApp ASP.NET Core MVC

This is an ASP.NET Core MVC web application that fetches weather information such as temperature and "feels like" temperature using the OpenWeather API. The project follows a Model-View-Controller (MVC) architecture, which is standard for ASP.NET applications.

## Project Structure

- **Controllers**: Handle requests and user interaction.
- **Views**: Razor views for displaying HTML.
- **Models**: Data models for binding the weather data.
- **Services**: Services for interacting with the OpenWeather API.

## How to Run

1. **Clone or Download the Repository**: Download the project files or clone the repository.
2. **Add API Key**: Replace `your_openweather_api_key` in the `Startup.cs` with your actual OpenWeather API key.
3. **Build and Run**: Build the project using your preferred C# development environment (e.g., Visual Studio) and run the application.

## Dependencies

- **Newtonsoft.Json**: For JSON serialization and deserialization.
- **Microsoft.Extensions.DependencyInjection**: For managing dependency injection.
- **System.Net.Http**: For making HTTP requests.

## Usage

1. Run the application.
2. Enter the name of the city for which you want to fetch the weather information.
3. The application will display the current temperature and "feels like" temperature for the city.

## Example

```
Enter city name: London
City: London
Temperature: 15.0°C
Feels Like: 13.0°C
Description: clear sky
```

## License

This project is open-source and available under the MIT License.
