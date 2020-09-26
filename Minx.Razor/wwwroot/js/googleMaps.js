window.maps = {
    markers: [],
    addScript: function (componentInstance) {
        // Create the script tag, set the appropriate attributes
        var script = document.createElement('script');
        script.src = 'https://maps.googleapis.com/maps/api/js?key=AIzaSyApCKgLSrnG-EULampbTi2IQI3BwRy5Eu0&callback=maps.initMap';
        script.defer = true;
        script.async = true;

        var currentThis = this === window
            ? this.maps
            : this;

        currentThis.instance = componentInstance;

        //// Attach your callback function to the `window` object
        //window.initMap = function () {
        //    // JS API is loaded and available
        //};

        // Append the 'script' element to 'head'
        document.head.appendChild(script);

    },
    initMap: function () {

        var currentThis = this === window
            ? this.maps
            : this;

        // The location of London
        var london = { lat: 51.509865, lng: -0.118092 };
        // The map, centered at London
        currentThis.map = new google.maps.Map(
            document.getElementById("map"), { zoom: 10, center: london });
       
        this.instance.invokeMethodAsync('Map', 'LoadMarkers');
        //marker.setLabel("Hello World!");
        //console.log("Hello");
    },
    addOrganisationMarker: function (text, lat, long, reference) {

        var pos = { lat: lat, lng: long };

        var marker = new google.maps.Marker({ position: pos, map: this.map });

        this.markers.push(marker);
        // marker.setLabel(text);

        // var instance = this.instance;

        marker.reference = reference;
        marker.instance = this.instance;

        google.maps.event.addListener(marker, 'click', function() {
            console.log(this.reference);

            this.instance.invokeMethodAsync('OrganisationSelected', this.reference);
        });
        
        // marker.addListener();
    },
    addActivityMarker: function (text, lat, long, reference) {

        var pos = { lat: lat, lng: long };

        var marker = new google.maps.Marker({ position: pos, map: this.map });

        this.markers.push(marker);
        // marker.setLabel(text);

        // var instance = this.instance;

        marker.reference = reference;
        marker.instance = this.instance;

        google.maps.event.addListener(marker, 'click', function() {
            console.log(this.reference);

            this.instance.invokeMethodAsync('ActivitySelected', this.reference);
        });

        // marker.addListener();
    },
    clearMarkers: function () {
        for (let i = 0; i < this.markers.length; i++)
        {
            this.markers[i].setMap(null);
        }
        this.markers = [];
    }
};