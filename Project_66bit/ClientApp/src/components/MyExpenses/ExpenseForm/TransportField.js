import React from 'react';

const TransportField = (props) => {
    if (props.render) {
        return (
            <div className="form-group col-md-4">
                <label>Транспорт</label>
                <input className="form-control" type="text"></input>
            </div>
        );
    }

    return "";
}

export default TransportField;