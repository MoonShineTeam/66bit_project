import React from 'react';

const AccommodationField = (props) => {
    if (props.render) {
        return (
            <div className="form-group col-md-4">
                <label>Жилье</label>
                <input className="form-control" type="text"></input>
            </div>
        );
    }

    return "";
}

export default AccommodationField;
