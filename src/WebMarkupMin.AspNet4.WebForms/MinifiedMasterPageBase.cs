﻿using System.Web.UI;

using WebMarkupMin.AspNet4.WebForms.Components;

namespace WebMarkupMin.AspNet4.WebForms
{
	/// <summary>
	/// Base class of master page with support of markup minification
	/// </summary>
	public abstract class MinifiedMasterPageBase : MasterPage
	{
		/// <summary>
		/// Minified component
		/// </summary>
		private readonly MinifiedComponentBase _minifiedComponent;

		/// <summary>
		/// Gets or sets a flag for whether to disable markup minification
		/// </summary>
		public bool DisableMinification
		{
			get
			{
				return _minifiedComponent.DisableMinification;
			}
			set
			{
				_minifiedComponent.DisableMinification = value;
			}
		}


		/// <summary>
		/// Constructs a instance of master page with support of markup minification
		/// </summary>
		/// <param name="minifiedComponent">Minified component</param>
		protected MinifiedMasterPageBase(MinifiedComponentBase minifiedComponent)
		{
			_minifiedComponent = minifiedComponent;
		}


		protected override void Render(HtmlTextWriter writer)
		{
			_minifiedComponent.Render(writer, base.Render);
		}
	}
}