using BlogifyHub.Web.IServices;
using BlogifyHub.Web.Models;
using BlogifyHub.Web.Services;
using Microsoft.AspNetCore.Components;

namespace BlogifyHub.Web.Pages.Blog
{
    public partial class BlogDetailComponent
    {
        [Parameter]
        public string Id { get; set; }
        private BlogDto blog;
        [Inject]
        NavigationManager NavigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            blog = await _blogService.GetBlogById(Id);
        }

        private void GoBack()
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
