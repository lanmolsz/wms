﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;

namespace Dddml.Wms.Domain.ProductCategory
{
	public interface IProductCategoryCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string ProductCategoryId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteProductCategory : IProductCategoryCommand
	{

		string ProductCategoryTypeId { get; set; }

		string PrimaryParentCategoryId { get; set; }

		string CategoryName { get; set; }

		string Description { get; set; }

		string CategoryImageUrl { get; set; }

		string DetailScreen { get; set; }

		bool? ShowInSelect { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateProductCategory : ICreateOrMergePatchOrDeleteProductCategory
	{
	}

	public interface IMergePatchProductCategory : ICreateOrMergePatchOrDeleteProductCategory
	{

		bool IsPropertyProductCategoryTypeIdRemoved { get; set; }

		bool IsPropertyPrimaryParentCategoryIdRemoved { get; set; }

		bool IsPropertyCategoryNameRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyCategoryImageUrlRemoved { get; set; }

		bool IsPropertyDetailScreenRemoved { get; set; }

		bool IsPropertyShowInSelectRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteProductCategory : ICreateOrMergePatchOrDeleteProductCategory
	{
	}


}

