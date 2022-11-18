import React, { Component } from 'react';

export class FetchLabRecords extends Component {
    static displayName = FetchLabRecords.name;

    constructor(props) {
        super(props);
        this.state = { labrecords: [], loading: true };
    }

    componentDidMount() {
        this.populateLabRecords();
    }

    static renderLabRecordsTable(givenLabrecords) {
        return (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>Name</th>
                        <th>Measurement</th>
                    </tr>
                </thead>
                <tbody>
                    {givenLabrecords.map(lr =>                   
                        lr.labMeasurements.map(lrm =>
                            <tr>
                                <td>{lrm.dateMeasured}</td>
                                <td>{lr.name}</td>
                                <td>{lrm.value}</td>
                            </tr>
                        )
                    )}

                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchLabRecords.renderLabRecordsTable(this.state.labrecords);

        return (
          <div>
            <h1 id="tableLabel">Lab Records</h1>
            <p>This component demonstrates fetching data from configuration file.</p>
            {contents}
          </div>
        );
    }

    async populateLabRecords() {
        const response = await fetch('LabRecords');
        const data = await response.json();
        this.setState({ labrecords: data, loading: false });
    }
}
