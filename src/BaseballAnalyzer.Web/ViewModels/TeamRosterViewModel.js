$(function () {
    var viewModel;

    $.getJSON('/api/teamroster', function(data) {
		var model = data;

		viewModel = {
			players: ko.observableArray(model)
		};
		ko.applyBindings(viewModel);
	});
})