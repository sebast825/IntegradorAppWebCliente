﻿using AutoMapper;
using Azure;
using Integrador.Dal;
using Integrador.Dal.Entities;
using Integrador.Dto.Viajes;
using Integrador.Service.Interface;
using System.ComponentModel;
using System.Linq.Expressions;

namespace Integrador.Service
{
    public class ViajeService : IViajeService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ViajeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ViajeReponseDTO> Create(ViajeCreateRequestDTO dto)
        {
            /*
            if (_mapper == null)
            {
                throw new InvalidOperationException("Mapper no está inicializado.");
            }
            var viajeEntity = _mapper.Map<Viaje>(dto);

            await _unitOfWork.ViajeRepository.Add(viajeEntity);
                        var result = _mapper.Map<ViajeReponseDTO>(dto);

            */
            ViajeReponseDTO response = new ViajeReponseDTO();
            return await Task.FromResult(response);
        }

        public async Task<List<ViajeReponseDTO>> GetAll()
        {

            var viajes = await _unitOfWork.ViajeRepository.GetAll();
            var result = _mapper.Map<List<ViajeReponseDTO>>(viajes);

            return result;
            /*  
             * DE FORMA MANUAL, SIN EL MAPPER
             *  var viajes = await _unitOfWork.ViajeRepository.GetAll();

              var listaViajes = new List<ViajeReponseDTO>();
              foreach(Viaje viaje in  viajes)
              {
                  var camion = viaje.Camion;
                  var duracionViaje = (viaje.FechaLLegada - viaje.FechaSalida).TotalHours;

                  var viajeDto =  new ViajeReponseDTO
                  {
                      Dominio = camion?.Dominio,
                  Conductor = camion?.Conductor,
                  CiudadOrigen = viaje.CiudadOrigen,
                  CiudadDestino = viaje.CiudadDestino,
                  FechaHoraSalida = viaje.FechaSalida.ToString(),
                  FechaHoraLlegada = viaje.FechaLLegada.ToString(),
                  Distancia = viaje.kilometraje.ToString(),
                 DuracionViaje = Convert.ToDecimal(duracionViaje)
              };
                  listaViajes.Add(viajeDto);
              }
              foreach(ViajeReponseDTO viaje in listaViajes)
              {
                  Console.WriteLine(viaje.Conductor);
              }
              return listaViajes;
            */
        }

        public async Task<List<ViajeReponseDTO>> GetByDomimnio(string dominio)
        {
            var viajes = await _unitOfWork.ViajeRepository.GetByDominio(dominio);
            var result = _mapper.Map<List<ViajeReponseDTO>>(viajes);

            return result;
        }

      
    }
}
