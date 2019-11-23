﻿using BlazorClientTest.Shared.Interfaces;
using BlazorClientTest.Shared.Models;
using System.Collections.Generic;

namespace BlazorClientTest.Shared.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherForecastRepository.Get();
        }
    }
}