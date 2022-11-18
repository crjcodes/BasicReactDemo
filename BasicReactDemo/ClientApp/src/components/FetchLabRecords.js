import React, { Component } from 'react';
import FilterableTable from 'react-filterable-table';

export class FetchLabRecords extends Component {
    static displayName = FetchLabRecords.name;

    constructor(props) {
        super(props);
        this.state = { labrecords: [], loading: true };
    }

    componentDidMount() {
        this.populateLabRecords();
    }

    static renderFilterableTable(givenLabrecords) {
        const fields = [
            { name: 'name', displayName: "Name", inputFilterable: true, sortable: true },
            { name: 'dateMeasured', displayName: "When Measured", inputFilterable: true, exactFilterable: true, sortable: true },
            { name: 'value', displayName: "Value", inputFilterable: true, exactFilterable: true, sortable: true },
        ];
        return (
            <FilterableTable
                namespace="LabRecords"
                initialSort="name"
                data={givenLabrecords}
                fields={fields}
                noRecordsMessage="No labwork to display"
                noFilteredRecordsMessage="No labwork matches the current filter"
            />
        );
    }

    render() {
        let contents = <p><em>Loading...</em></p>
        let filteredTable = <p></p>;
        if (!this.state.loading) {
            //contents = FetchLabRecords.renderLabRecordsTable(this.state.labrecords);
            filteredTable = FetchLabRecords.renderFilterableTable(this.state.labrecords);
        }

        return (
          <div>
            <h1 id="tableLabel">Lab Records</h1>
            <p>This component demonstrates fetching data from configuration file.</p>
                {filteredTable}
          </div>
        );
    }

    async populateLabRecords() {
        const response = await fetch('LabRecords');
        const data = await response.json();
        this.setState({ labrecords: data, loading: false });
    }
}
