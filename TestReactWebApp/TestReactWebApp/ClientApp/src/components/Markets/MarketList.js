import React, { Component } from 'react';
import { Glyphicon } from 'react-bootstrap';

export class MarketList extends Component {
    static renderMarketsTable(markets) {
        return (
            <table className="table">
                <thead>
                    <tr>
                        <th>Market Description</th>
                        <th>Cookie Value</th>
                        <th>Culture Code</th>
                        <th>Is Default</th>
                        <th>Main Country</th>
                    </tr>
                </thead>
                <tbody>
                    {markets.map(market =>
                        <tr key={market.name}>
                            <td>{market.description}</td>
                            <td>{market.cookieValue}</td>
                            <td>{market.cultureCode}</td>
                            <td>{market.isDefault && <Glyphicon glyph="ok" style={{color: "#4BB543"}} />}</td>
                            <td>{market.mainCountry}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    displayName = MarketList.name

    constructor(props) {
        super(props);
        this.state = {
            markets: [],
            loading: true
        };

        fetch('api/Market/GetMarkets')
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                this.setState({
                    markets: data.markets,
                    loading: false
                });
            }
            else {
                console.error(data.message);
            }
        })
        .catch((error) => {
            console.error(error);
        });
    }



    render() {
        let contents = this.state.loading
            ? <p><em> Loading... </em></p>
            : MarketList.renderMarketsTable(this.state.markets);

        return (
            <div>
                <h1>Markets</h1>
                {contents}
            </div>
        );
    }
}
