﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NatShopB2C.Domain.IServices;
using NatShopB2C.Domain.Services;
using NatShopB2C.EF.Common.DTO;
using NatShopB2C_API.AccountModels;

namespace NatShopB2C_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("/api/Category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        protected Response response;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
            this.response = new();
        }

        [HttpGet]
        [Route("GetCategories")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetCategories(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve)
        {
            {
                try
                {
                    var categories = await _categoryService.GetCategories(StartIndex, EndIndex, IsActive, IsArchieve);
                    if (categories == null)
                    {
                        return NotFound();
                    }
                    var list = categories;
                    response.Result = list;
                    response.StatusCode = System.Net.HttpStatusCode.OK;
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return response;

            }
        }
        [HttpGet]
        [Route("GetcategoryHierarchy")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetcategoryHierarchy(int? StartIndex, int? EndIndex, bool? IsActive, bool? IsArchieve, string? SearchString)
        {
            {
                try
                {
                    var categories = await _categoryService.GetcategoryHierarchy(StartIndex, EndIndex, IsActive, IsArchieve, SearchString);
                    if (categories == null)
                    {
                        return NotFound();
                    }
                    //var list = categories;
                    response.Result = _mapper.Map<List<CategoryHierarchyDTO>>(categories);
                    response.StatusCode = System.Net.HttpStatusCode.OK;
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return response;

            }
        }


        [HttpGet]
        [Route("Getcategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Response>> GetCategory(string? CategoryName, int? Id)
        {
            {
                try
                {
                    var categories = await _categoryService.GetCategory(CategoryName, Id);
                    if (categories == null)
                    {
                        return NotFound();
                    }
                    //var list = categories;
                    response.Result = _mapper.Map<List<CategoryDTO>>(categories);
                    response.StatusCode = System.Net.HttpStatusCode.OK;
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    response.IsSuccess = false;
                    response.ErrorMessages = new List<string>() { ex.ToString() };
                }
                return response;

            }
        }
        //[HttpGet]
        //[Route("GetCategoriesSlider")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public async Task<ActionResult<Response>> GetCategoriesSlider()
        //{
        //    {
        //        try
        //        {
        //            var categories = await _categoryService.GetCategoriesSlider();
        //            if (categories == null)
        //            {
        //                return NotFound();
        //            }
        //            //var list = categories;
        //            response.Result = categories;
        //            response.StatusCode = System.Net.HttpStatusCode.OK;
        //            return Ok(response);
        //        }
        //        catch (Exception ex)
        //        {
        //            response.IsSuccess = false;
        //            response.ErrorMessages = new List<string>() { ex.ToString() };
        //        }
        //        return response;

        //    }
        //}
    }
}
