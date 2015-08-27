var contactDetails = angular.module('contactDetails', []);

contactDetails.controller('ContactController', ['$scope', ContactController]);
function ContactController($scope)
{
    $scope.contacts = [];
    $scope.newcontact = [];
    $scope.saveContact = function () {
        
        if ($scope.newcontact.id == undefined) {
            $scope.newcontact.id = $scope.contacts.length;
            $scope.contacts.push($scope.newcontact);
        }
        else {
            var index = getItemIndex($scope.contacts, $scope.newcontact.id);
            $scope.contacts[index] = $scope.newcontact;
        }
        
        $scope.newcontact = [];        
    };

    $scope.delete = function (idToDelete) {
        var index = getItemIndex($scope.contacts, idToDelete);
        $scope.contacts.splice(index, 1);
    };

    $scope.edit = function (idToEdit) {
        var index = getItemIndex($scope.contacts, idToEdit);
        var foundItem = $scope.contacts[index];
        $scope.newcontact.id = foundItem.id;
        $scope.newcontact.name = foundItem.name;
        $scope.newcontact.mobile = foundItem.mobile;
        $scope.newcontact.email = foundItem.email;
    };
}

function getItemIndex(objContacts, id)
{
    var index = -1;    
    for (var i = 0; i < objContacts.length; i++) {
        if (objContacts[i].id === id) {
            index = i;
            break;
        }
    }
    
    return index;
}