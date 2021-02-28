# Setting Minx up in Blazor

1. Add the `nuget` package
2. Add imports to `_Imports.razor`
	```
	@using CommunityBridges.WebApp.Shared
	@using Minx.Razor.Components
	@using Minx.Razor.Inputs
	@using Minx.Razor.Services
	@using Minx.Razor.Models
	```
3. Add styles to `index.html`
	```
	<link href="_content/Minx.Razor/css/styles.css" rel="stylesheet" /
	```
4. Add scripts to `index.html`
	```
	<script src="_content/Minx.Razor/js/inputFile.js"></script>
    	<script src="_content/Minx.Razor/js/saveFile.js"></script>
    	<script src="_content/Minx.Razor/js/googleMaps.js"></script>
	```
5. Register services in `Program.cs`
	```
	builder.Services.AddScoped<ModalService>();
        builder.Services.AddScoped<LoadingScreenService>();
	```
6. Add Components to `MainLayout.razor`
	```
	<Modal></Modal>
	<LoadingScreen></LoadingScreen>
	```

