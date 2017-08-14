<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Google_Map_API.aspx.cs" Inherits="Dev_Forms.Google_API" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
<section class="panel panel-default">
        <header class="panel-heading">
            <h3 class="panel-title">Description</h3>
        </header>
        <div class="panel-body">
            <p>I'm sure we've all come across some point where we would like to constrain how addresse are entered into a dataset.  
                If there is no single inventory of locations that support your department/business then why not leverage an existing 
                data set from Google!  Auto complete search aids in the selection of location while the returned values are stored
                within the application.
            </p>
        </div>
    </section>
    </div>
    
    <div class="row" style="padding: 0 15px">
        <div class="form-horizontal" role="form" method="get" action="#">
            <input type="text" class="form-control" style="width: 400px" id="autocomplete" placeholder="Start typing address here" />
            <p />
            <p />
            <div class="well col-md-6">
                <div class="form-group">
                    <label for="civ_street" class="col-sm-2 control-label">Civic Address</label>
                    <div class="col-md-1"></div>
                    <input type="text" readonly="readonly" class="form-control" id="civ_street" />

                </div>

                <div class="form-group">
                    <label for="city" class="col-sm-2 control-label">City</label>
                    <div class="col-md-1"></div>
                    <input type="text" readonly="readonly" class="form-control" id="city" />

                </div>

                <div class="form-group">
                    <label for="province" class="col-sm-2 control-label">Province</label>
                    <div class="col-md-1"></div>
                    <input type="text" readonly="readonly" class="form-control" id="province" />

                </div>
                <div class="form-group">
                    <label for="postal" class="col-sm-2 control-label">Postal Code</label>
                    <div class="col-md-1"></div>
                    <input type="text" readonly="readonly" class="form-control" id="postal" />

                </div>

                <div class="form-group">
                    <label for="country" class="col-sm-2 control-label">Country</label>
                    <div class="col-md-1"></div>
                    <input type="text" readonly="readonly" class="form-control" id="country" />

                </div>
            </div>
        </div>
        <div class="col-md-6 ">
            <div id="map" style="height: 300px"></div>
        </div>
    </div>
    <div class="h3">Code:</div>
    <pre><code>
        var map;
        var input;
        var placeSearch, autocomplete;
        var componentForm = {
            street_number: 'short_name',
            route: 'short_name',
            locality: 'long_name',
            administrative_area_level_1: 'short_name',
            country: 'long_name',
            postal_code: 'short_name'
        };
        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: 45.4214, lng: -75.6919 },
                zoom: 8
            });
            input = document.getElementById('autocomplete');
            var autocomplete = new google.maps.places.Autocomplete(input);
            var infowindow = new google.maps.InfoWindow();
            var marker = new google.maps.Marker({
                map: map,
                anchorPoint: new google.maps.Point(0, -29)
            });
            autocomplete.addListener('place_changed', function () {
                infowindow.close();

                marker.setVisible(false);
                var place = autocomplete.getPlace();
                if (!place.geometry) {
                    window.alert("Autocomplete's returned place contains no geometry");
                    return;
                }
                fillInAddress(place);
                // If the place has a geometry, then present it on a map.
                if (place.geometry.viewport) {
                    map.fitBounds(place.geometry.viewport);
                } else {
                    map.setCenter(place.geometry.location);
                    map.setZoom(17);  // Why 17? Because it looks good.
                }
                marker.setIcon(/** @type {google.maps.Icon} */({
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(35, 35)
                }));
                marker.setPosition(place.geometry.location);
                marker.setVisible(true);

                var address = '';
                if (place.address_components) {
                    address = [
                      (place.address_components[0] && place.address_components[0].short_name || ''),
                      (place.address_components[1] && place.address_components[1].short_name || ''),
                      (place.address_components[2] && place.address_components[2].short_name || '')
                    ].join(' ');
                }

                infowindow.setContent('&lt;div&gt;&lt;strong&gt;' + place.name + '&lt;/strong&gt;&lt;br&gt;' + address);
                infowindow.open(map, marker);
            });

        }
        function fillInAddress(place) {
            // Get the place details from the autocomplete object.
            var civic = document.getElementById('civ_street');
            var city = document.getElementById('city');
            var province = document.getElementById('province');
            var postal = document.getElementById('postal');
            var country = document.getElementById('country');
            var street_num = ''
            civic.value = '';
            city.value = '';
            province.value = '';
            postal.value = '';
            country.value = '';
            
                      
            for (var i = 0; i < place.address_components.length; i++) {
                var addressType = place.address_components[i].types[0];
                if (addressType == 'street_number') {
                    var val = place.address_components[i][componentForm[addressType]];
                    street_num = val
                }
                if (addressType == 'route') {
                    var val = place.address_components[i][componentForm[addressType]];
                    civic.value = street_num + ' ' + val;
                }
                if (addressType == 'locality') {
                    var val = place.address_components[i][componentForm[addressType]];
                    city.value = val;
                }
                if (addressType == 'administrative_area_level_1') {
                    var val = place.address_components[i][componentForm[addressType]];
                    province.value = val;
                }
                if (addressType == 'country') {
                    var val = place.address_components[i][componentForm[addressType]];
                    country.value = val;
                }
                if (addressType == 'postal_code') {
                    var val = place.address_components[i][componentForm[addressType]];
                    postal.value = val;
                }
            }
            
        }

        // Bias the autocomplete object to the user's geographical location,
        // as supplied by the browser's 'navigator.geolocation' object.
        function geolocate() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    var geolocation = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    };
                    var circle = new google.maps.Circle({
                        center: geolocation,
                        radius: position.coords.accuracy
                    });
                    autocomplete.setBounds(circle.getBounds());
                });
            }
        }
        // [END region_geolocation]
   
    </code></pre>



    <script type="text/javascript">
        var map;
        var input;
        var placeSearch, autocomplete;
        var componentForm = {
            street_number: 'short_name',
            route: 'short_name',
            locality: 'long_name',
            administrative_area_level_1: 'short_name',
            country: 'long_name',
            postal_code: 'short_name'
        };
        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: 45.4214, lng: -75.6919 },
                zoom: 8
            });
            input = document.getElementById('autocomplete');
            var autocomplete = new google.maps.places.Autocomplete(input);
            var infowindow = new google.maps.InfoWindow();
            var marker = new google.maps.Marker({
                map: map,
                anchorPoint: new google.maps.Point(0, -29)
            });
            autocomplete.addListener('place_changed', function () {
                infowindow.close();

                marker.setVisible(false);
                var place = autocomplete.getPlace();
                if (!place.geometry) {
                    window.alert("Autocomplete's returned place contains no geometry");
                    return;
                }
                fillInAddress(place);
                // If the place has a geometry, then present it on a map.
                if (place.geometry.viewport) {
                    map.fitBounds(place.geometry.viewport);
                } else {
                    map.setCenter(place.geometry.location);
                    map.setZoom(17);  // Why 17? Because it looks good.
                }
                marker.setIcon(/** @type {google.maps.Icon} */({
                    url: place.icon,
                    size: new google.maps.Size(71, 71),
                    origin: new google.maps.Point(0, 0),
                    anchor: new google.maps.Point(17, 34),
                    scaledSize: new google.maps.Size(35, 35)
                }));
                marker.setPosition(place.geometry.location);
                marker.setVisible(true);

                var address = '';
                if (place.address_components) {
                    address = [
                      (place.address_components[0] && place.address_components[0].short_name || ''),
                      (place.address_components[1] && place.address_components[1].short_name || ''),
                      (place.address_components[2] && place.address_components[2].short_name || '')
                    ].join(' ');
                }

                infowindow.setContent('<div><strong>' + place.name + '</strong><br>' + address);
                infowindow.open(map, marker);
            });

        }
        function fillInAddress(place) {
            // Get the place details from the autocomplete object.
            var civic = document.getElementById('civ_street');
            var city = document.getElementById('city');
            var province = document.getElementById('province');
            var postal = document.getElementById('postal');
            var country = document.getElementById('country');
            var street_num = ''
            civic.value = '';
            city.value = '';
            province.value = '';
            postal.value = '';
            country.value = '';


            for (var i = 0; i < place.address_components.length; i++) {
                var addressType = place.address_components[i].types[0];
                if (addressType == 'street_number') {
                    var val = place.address_components[i][componentForm[addressType]];
                    street_num = val
                }
                if (addressType == 'route') {
                    var val = place.address_components[i][componentForm[addressType]];
                    civic.value = street_num + ' ' + val;
                }
                if (addressType == 'locality') {
                    var val = place.address_components[i][componentForm[addressType]];
                    city.value = val;
                }
                if (addressType == 'administrative_area_level_1') {
                    var val = place.address_components[i][componentForm[addressType]];
                    province.value = val;
                }
                if (addressType == 'country') {
                    var val = place.address_components[i][componentForm[addressType]];
                    country.value = val;
                }
                if (addressType == 'postal_code') {
                    var val = place.address_components[i][componentForm[addressType]];
                    postal.value = val;
                }
            }

        }

        // [END region_fillf

        // [START region_geolocation]
        // Bias the autocomplete object to the user's geographical location,
        // as supplied by the browser's 'navigator.geolocation' object.
        function geolocate() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(function (position) {
                    var geolocation = {
                        lat: position.coords.latitude,
                        lng: position.coords.longitude
                    };
                    var circle = new google.maps.Circle({
                        center: geolocation,
                        radius: position.coords.accuracy
                    });
                    autocomplete.setBounds(circle.getBounds());
                });
            }
        }
        // [END region_geolocation]
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAgTlK95MUNbdfw3qWRUE-TpZeVJnxQjhk&libraries=places&callback=initMap"
        async defer></script>

</asp:Content>
